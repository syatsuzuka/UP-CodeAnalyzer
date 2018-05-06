# UP-CodeAnalyzer

This is an open source project to develop custom activity for UiPath which conducts static analysis of UiPath's workflow files.


## How to Create NuGet

Step.1) Clone this project to your pc

Step.2) Run build to create dll

Step.3) Create NuGet package following the following instruction

https://activities.uipath.com/docs/creating-a-custom-activity


## Activities

* ReadXAML: Read XAML file specified in "InputFile" and output XDocument
* AnalyzeXAML: Analyze XAML Data (XDocument) and output Structure Info (XDocument), Issue List (DataTable), and Statistic List (DataTable).

