# Android Resources SVG Source Files

This directory contains the source SVG files for the Android resources. These
files are used with Android Studio to generate the xml vector images and webp
raster images for the app icon, splash screen, and other resources.

This process is not automated, and must be done manually. The following steps
are required to generate the resources:

## Generating a general vector asset
1. Open a new Android Studio project.
2. Right click on the "res" directory and select "New > Vector Asset".
3. Select the "Local file (SVG, PSD)" option and click "Next".
4. Click "Choose File" and select the SVG file.
5. Click "Next".
6. Click "Finish".

## Generating the app icon
1. From the icon svg file in this directory, split the file into the foreground
   and background layers, and an optional monochrome foreground layer (for
    making your icon compatible with themed icons), and save them as separate
    files:
    - `ic_launcher_foreground.svg`
    - `ic_launcher_background.svg`
    - `ic_launcher_monochrome.svg`
2. Open a new Android Studio project.
3. Right click on the "res" directory and select "New > Image Asset".
4. Select the "Launcher Icons (Adaptive and Legacy)" option and click "Next".
5. On the "Foreground Layer" tab, click "Image" and select the foreground svg.
6. On the "Background Layer" tab, click "Image" and select the background svg.
7. Click "Next".
8. Click "Finish".
9. If you have a monochrome layer, import it as a general vector asset and
   edit `ic_launcher.xml` to add the monochrome layer:

```xml
<?xml version="1.0" encoding="utf-8"?>
<adaptive-icon xmlns:android="http://schemas.android.com/apk/res/android">
    <background android:drawable="@drawable/ic_launcher_background"/>
    <foreground android:drawable="@drawable/ic_launcher_foreground"/>
    <monochrome android:drawable="@drawable/ic_launcher_monochrome"/>
</adaptive-icon>
```
