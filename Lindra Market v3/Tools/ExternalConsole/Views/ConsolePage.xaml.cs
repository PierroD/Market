using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using MarketOffsets.Services;
using Lindra_Market_v3.Tools.ExternalConsole.Models;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Tools.ExternalConsole.Views
{
    public partial class ConsolePage : Page
    {
        private readonly ObservableCollection<ConsoleHistoryEntry> _history = new();

        public ConsolePage()
        {
            InitializeComponent();
            HistoryItemsControl.ItemsSource = _history;
            UpdatePlaceholder();
            UpdateHistoryEmptyState();

            ConsoleWindow.OnInsertCommandRequested += HandleInsertCommand;
            Unloaded += (s, e) => ConsoleWindow.OnInsertCommandRequested -= HandleInsertCommand;
        }

        public void AppendCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command)) return;

            if (string.IsNullOrWhiteSpace(EditorTextBox.Text))
            {
                EditorTextBox.Text = command;
            }
            else
            {
                EditorTextBox.Text = EditorTextBox.Text.TrimEnd() + Environment.NewLine + command;
            }

            EditorTextBox.CaretIndex = EditorTextBox.Text.Length;
            EditorTextBox.Focus();
        }

        private void HandleInsertCommand(string command)
        {
            Dispatcher.Invoke(() => AppendCommand(command));
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            ExecuteEditorCommands();
        }

        private void EditorTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                e.Handled = true;
                ExecuteEditorCommands();
            }
        }

        private async void ExecuteEditorCommands()
        {
            string rawText = EditorTextBox.Text;
            if (string.IsNullOrWhiteSpace(rawText))
            {
                StatusInfoText.Text = string.Empty;
                return;
            }

            var commands = rawText.Split(new[] { "\r\n", "\r", "\n", ";" }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(c => c.Trim())
                                  .Where(c => !string.IsNullOrEmpty(c))
                                  .ToList();

            if (commands.Count == 0) return;

            if (!GameMemoryService.Instance.IsGameAttached)
            {
                string noGameMsg = LanguageManager.GetString("Console_Log_NoGame", "Erreur : Aucun jeu compatible détecté ou attaché.");
                StatusInfoText.Text = noGameMsg;

                _history.Insert(0, new ConsoleHistoryEntry
                {
                    Timestamp = DateTime.Now,
                    Command = commands.First(),
                    IsSuccess = false,
                    Message = noGameMsg
                });
                UpdateHistoryEmptyState();
                return;
            }

            int successCount = 0;
            BtnSend.IsEnabled = false;

            try
            {
                for (int i = 0; i < commands.Count; i++)
                {
                    var cmd = commands[i];
                    bool success = GameMemoryService.Instance.SendConsoleCommand(cmd);
                    if (success) successCount++;

                    _history.Insert(0, new ConsoleHistoryEntry
                    {
                        Timestamp = DateTime.Now,
                        Command = cmd,
                        IsSuccess = success,
                        Message = success
                            ? LanguageManager.GetString("Console_Log_Success", "Exécuté avec succès")
                            : LanguageManager.GetString("Console_Log_Failed", "Échec de l'exécution")
                    });

                    // Small pause between commands so the game engine loop has time to consume each command safely
                    if (commands.Count > 1 && i < commands.Count - 1)
                    {
                        await Task.Delay(25);
                    }
                }
            }
            finally
            {
                BtnSend.IsEnabled = true;
            }

            UpdateHistoryEmptyState();
            StatusInfoText.Text = $"{successCount}/{commands.Count} " + LanguageManager.GetString("Console_Log_Success", "commandes envoyées");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            EditorTextBox.Clear();
            StatusInfoText.Text = string.Empty;
            EditorTextBox.Focus();
        }

        private void BtnClearLog_Click(object sender, RoutedEventArgs e)
        {
            _history.Clear();
            UpdateHistoryEmptyState();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = LanguageManager.GetString("Console_Dialog_CfgFilter", "Fichiers Config (*.cfg;*.txt)|*.cfg;*.txt|Tous les fichiers (*.*)|*.*"),
                Title = LanguageManager.GetString("Console_Btn_Load", "Charger un fichier de configuration")
            };

            if (dialog.ShowDialog() == true)
            {
                try
                {
                    string content = File.ReadAllText(dialog.FileName);
                    if (string.IsNullOrWhiteSpace(EditorTextBox.Text))
                    {
                        EditorTextBox.Text = content;
                    }
                    else
                    {
                        EditorTextBox.Text = EditorTextBox.Text.TrimEnd() + Environment.NewLine + content;
                    }

                    string loadedPrefix = LanguageManager.GetString("Console_Loaded_File", "Fichier chargé : ");
                    StatusInfoText.Text = $"{loadedPrefix}{Path.GetFileName(dialog.FileName)}";
                }
                catch (Exception ex)
                {
                    StatusInfoText.Text = ex.Message;
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EditorTextBox.Text))
                return;

            var dialog = new SaveFileDialog
            {
                Filter = LanguageManager.GetString("Console_Dialog_CfgFilter", "Fichiers Config (*.cfg;*.txt)|*.cfg;*.txt|Tous les fichiers (*.*)|*.*"),
                DefaultExt = ".cfg",
                Title = LanguageManager.GetString("Console_Btn_Save", "Sauvegarder la configuration")
            };

            if (dialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, EditorTextBox.Text);
                    string savedPrefix = LanguageManager.GetString("Console_Saved_File", "Sauvegardé dans : ");
                    StatusInfoText.Text = $"{savedPrefix}{Path.GetFileName(dialog.FileName)}";
                }
                catch (Exception ex)
                {
                    StatusInfoText.Text = ex.Message;
                }
            }
        }

        private void EditorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePlaceholder();
        }

        private void UpdatePlaceholder()
        {
            if (PlaceholderTextBlock != null)
            {
                PlaceholderTextBlock.Visibility = string.IsNullOrEmpty(EditorTextBox?.Text)
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
        }

        private void UpdateHistoryEmptyState()
        {
            if (EmptyHistoryText != null)
            {
                EmptyHistoryText.Visibility = _history.Count == 0
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
        }
    }
}
