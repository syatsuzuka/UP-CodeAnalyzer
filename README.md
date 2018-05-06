# UP-CodeAnalyzer

This is an open source project to develop custom activity for UiPath which conducts static analysis of UiPath's workflow files.


## How to Create NuGet

Step.1) Clone this project to your pc

Step.2) Run build to create dll

Step.3) Create NuGet package following the following instruction

https://activities.uipath.com/docs/creating-a-custom-activity


## How to Run

Step.1) Open the attached Workflow file with UiPath Studio

Step.2) Install created NuGet package

Step.3) Run Main.xaml. Then you should be able to find report files in "Output" folder


## Activities

* ReadXAML: Read XAML file specified in "InputFile" and output XDocument
* AnalyzeXAML: Analyze XAML Data (XDocument) and output Structure Info (XDocument), Issue List (DataTable), and Statistic List (DataTable).


