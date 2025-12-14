# TimeScale Toolbar

* Adds a Slider to change the TimeScale the to the main toolbar.
* Unity minimum version: **6000.3**
* Current version: **1.0.0**
* License: **MIT**

## Summary

Adds a slider to the main toolbar to quickly change `Time.TimeScale`.

![Time Scale](/Docs~/TimeScale.png)

Configure it through: Edit > Project Settings > ActionCode > TimeScale ToolBar.

Any changes made to the `Time.timeScale` from the game's logic will be prioritized over the toolbar unless the **Forced TimeScale** Override toggle is checked.

### Original Code

Original asset created by [bl4st](https://assetstore.unity.com/packages/tools/utilities/timescale-toolbar-291564)

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-TimeScaleToolbar** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/TimeScaleToolbar.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.time-scale-toolbar":"https://github.com/HyagoOliveira/TimeScaleToolbar.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>
