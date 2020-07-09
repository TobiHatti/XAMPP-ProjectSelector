<img align="right" width="80" height="80" data-rmimg src="https://endev.at/content/projects/XPS/XPS_Logo.svg">

# XAMPP-ProjectSelector

[![GitHub](https://img.shields.io/github/license/TobiHatti/XAMPP-ProjectSelector)](https://opensource.org/licenses/GPL-3.0)
[![GitHub Release Date](https://img.shields.io/github/release-date-pre/TobiHatti/XAMPP-ProjectSelector)](https://github.com/TobiHatti/XAMPP-ProjectSelector/releases)
[![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/TobiHatti/XAMPP-ProjectSelector?include_prereleases)](https://github.com/TobiHatti/XAMPP-ProjectSelector/releases)
[![GitHub last commit](https://img.shields.io/github/last-commit/TobiHatti/XAMPP-ProjectSelector)](https://github.com/TobiHatti/XAMPP-ProjectSelector/commits/master)
[![GitHub issues](https://img.shields.io/github/issues-raw/TobiHatti/XAMPP-ProjectSelector)](https://github.com/TobiHatti/XAMPP-ProjectSelector/issues)
[![GitHub language count](https://img.shields.io/github/languages/count/TobiHatti/XAMPP-ProjectSelector)](https://github.com/TobiHatti/XAMPP-ProjectSelector)

![image](https://endev.at/content/projects/XPS/XPS_Banner_300.png)

## What is it?
The XAMPP Project-Selector (XPS) provides a simple yet powerful tool which extends the functionality of the default XAMPP Control Panel. It provides the functionality to switch between multiple Projects, e.g. Websites, APIs and so on, without having to manualy edit an apache config-file. In other words, it changes the root-path and therefor the project/website/... which gets called when you call http://localhost or http://127.0.0.1 in your browser.

## Why do I need it?
Imagine you are working on multiple websites at once. If you now want to switch from one project to another, you would have to:
- Copy the entire project out of your default htdocs folder and copy the other project into it, or
- Manually edit the Apache-Config to change the root-path.

With the XPS, you can do all of this within a second by simply clicking a button.

![image](https://endev.at/content/projects/XPS/projectImages/MainTab.jpg)
![image](https://endev.at/content/projects/XPS/projectImages/ManagerTab.jpg)

## How does it work?
### General
The XPS ___does not___ replace XAMPP itself, it meerly interfaces with all of XAMPP's functions and extends them. 

### Services
![image](https://endev.at/content/projects/XPS/projectImages/ServicesTab.jpg)

You can Start/Stop services just like in the default Control-Panel by clicking on "Start" or "Stop". 
It is also possible to select services using the sliders on the left and start all of the selected services at once by clicking "Start Services" at the bottom.

Additionally, you can set "default-services" for every project, so you just have to set it up once when adding the project to the XPS, and then just click on "Start Services" without selecting your services every time.

![image](https://endev.at/content/projects/XPS/projectImages/ProjectEditor.jpg)

## Download
Get the latest release [here](https://github.com/TobiHatti/XAMPP-ProjectSelector/releases)
