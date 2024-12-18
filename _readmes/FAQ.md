### 🐛 How do I report a bug, a crash or an issue  ? 

You need to click on the following link : [https://github.com/PierroD/Market/issues/new](https://github.com/PierroD/Market/issues/new?assignees=PierroD&labels=bug&projects=&template=%F0%9F%90%9B-bug---issue-report.md&title=%5BBUG%5D+%2F+%5BISSUE%5D+keywords+or+short+sentence)

If you are using version `2.4.8` or newer, please provide the part of the log file that preceed the crash

> Follow the following instructions to find log file

- Go were Market is located (only god and you know where it's located)
- Find the `logs` folder in it
- You might see one or multiples files with the following naming : MarketLogs_XX-XX-XXXX
- Look at the latest one
- If you aren't able to locate the problem, please send the trace to the issue or mp me on discord `lindra`

Those logs are used to help me locating bug, optimizing code, etc... 

All of those data are stored localy (so you and only you will be able to access them)

I use them myself while building the app.

### 🔧 Tools available

- FPS Unlockers : unlock your in-game FPS and tweak your game settings

- External Console : it's a call of duty External console to inject some dvar

- Language Selector : add BlackOps 3 language files to the maps which doesn't support your language


### 🆕 How do I ask for a new feature ?

You need to click on the following link : [https://github.com/PierroD/Market/issues/new](https://github.com/PierroD/Market/issues/new)

### 📬 How do I update it ?

If an update is needed you will see the following buttons :

![](../_images/Update1.png)

And then click on the update button (you are also able to see what's included in the latest release)

![](../_images/Update2.png)

### 🛑 Is it bannable ?

I'm not working for Valve so there is always a risk !

### 🎮 Which games are supported ?

FPS Unlocker :

- Call of Duty 4 Modern Warfare - Multiplayer

- Call of Duty Modern Warfare 2 - Multiplayer

- Call of Duty BlackOps - Multiplayer

- Call of Duty Modern Warfare 3 - Multiplayer

- Call of Duty BlackOps 2 - Zombies

External Console :

- Call of Duty 4 Modern Warfare - Multiplayer

- Call of Duty Modern Warfare 2 - Multiplayer

- Call of Duty BlackOps - Multiplayer

- Call of Duty Modern Warfare 3 - Multiplayer

- Call of Duty BlackOps 2 - Zombies

Language Selector :

-  Call of Duty BlackOps 3

### 🤦 Can you add another Call of Duty Game ?

I can between Call of Duty 4 and Black Ops 2 inlcuded, but above the game is a 64bit based game and I don't know how to create those, sorry 🥲

### 🆓 Why does it take you so long to release an update ? 

I'm doing it on my free time, beside job, friends, family, etc...

And I also don't play those games anymore so I do it when I'm motivated to do it

### 🤔 Could you release a force host or something close to it ?

I prefer not to at the moment, but who knows 😏


### ❓ What does this do ?

This is all the console command included to the fps unlocker (with default value, and description) :

```json

  {
    "Content": "cg_fov \"65\" ",
    "Description": " The field of view angle in degrees"
  },
  {
    "Content": "cg_fovScale \"1\" ",
    "Description": " Scale applied to the field of view"
  },
  {
    "Content": "com_maxfps \"85\" ",
    "Description": " Cap frames per second"
  },
  {
    "Content": "r_lightMap \"Unchanged\" ",
    "Description": " Replace all lightmaps with pure black or pure white"
  },
  {
    "Content": "r_specularMap \"Unchanged\" ",
    "Description": " Replace all specular maps with pure black (off) or pure white (super shiny)"
  },
  {
    "Content": "r_filmUseTweaks \"0\" ", (Movie option)
    "Description": " Overide film effects with tweak dvar values."
  },
  {
    "Content": "r_fog \"1\" ",
    "Description": " Set to 0 to disable fog"
  },
  {
    "Content": "r_glow \"1\"",
    "Description": " Glow aspect in the game, weapon, etc"
  },
  {
    "Content": "cg_brass \"1\" ",
    "Description": " Weapons eject brass"
  },
  {
    "Content": "r_detail \"1\"",
    "Description": ""
  },
  {
    "Content": "r_detailMap \"Unchanged\" ",
    "Description": " Replace all detail maps with an image that effectively disables them"
  },
  {
    "Content": "profileMenuOption_safeAreaHorz \"1\" ",
    "Description": " Adjust the UI safeArea horizontally"
  },
  {
    "Content": "profileMenuOption_safeAreaVert \"1\" ",
    "Description": " Adjust the UI safeArea vertically"
  },
```

### 🖹 About the logger used by Market

It's a project I created in 2020, and I decided to implement it to this solution as it might help me and also helps you finding bugs, memory leaks etc...

Even if I did some testing before releasing it, to optimize the log generation (it will use some space on your disk), I do recommand to clear those logs once a while.

If you want to look forward, the project is also open source : [PLogger](https://github.com/pierrod/plogger)

If you don't have much disk space and you want to prevent the logger to generate a lot of logs you can "disable" most of them :

Find the file name : `LINDRA - Market.exe.config`

It should look like this :

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <section name="PLogger" type="PLogger.Configuration.PLoggerConfig, PLogger" />
  </configSections>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
  </startup>
  <PLogger>
    <targets>
      <add saveType="json" fileName="\\logs\\MarketLogs" filePath="" minLevel="Infos" detailMode="true" activityId="true" />
    </targets>
  </PLogger>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
```

You can edit the following line :

```xml
<!-- Actual version -->
   <add saveType="json" fileName="\\logs\\MarketLogs" filePath="" minLevel="Infos" detailMode="true" activityId="true" />
<!-- Do not log version -->
   <add saveType="json" fileName="\\logs\\MarketLogs" filePath="" minLevel="Fatal" detailMode="false" activityId="true" />
```