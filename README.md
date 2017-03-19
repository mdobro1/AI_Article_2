# AI_Article_2
Code-Samples and Demos for Artifical Intelligence article (2. issue) in dotnetpro-magazine (http://www.dotnetpro.de/)

# Demo and sample projects using Microsoft Computer Vision and Content Moderator API: Windows Client Library
This repo contains the Windows client library & sample for the Microsoft Computer Vision API, an offering within [Microsoft Cognitive Services](https://www.microsoft.com/cognitive-services), formerly known as Project Oxford.
* [Learn about the Computer Vision API](https://www.microsoft.com/cognitive-services/en-us/computer-vision-api)
* [Read the documentation](https://www.microsoft.com/cognitive-services/en-us/computer-vision-api/documentation)
* [Find more SDKs & Samples](https://www.microsoft.com/cognitive-services/en-us/SDK-Sample?api=computer%20vision)

## The Client Library
The client library is a thin C\# client wrapper for the Computer Vision API.

The easiest way to use this client library is to get microsoft.projectoxford.vision package from [nuget](<http://nuget.org>). Please go to [Vision API Package in nuget](https://www.nuget.org/packages/Microsoft.ProjectOxford.Vision/) for more details.

## The Samples List

1. Microsoft Computer Vision API: Windows Client Library & Sample (https://github.com/Microsoft/Cognitive-Vision-Windows/)
2. Microsoft Content Moderator API: Windows Client Library (https://github.com/MicrosoftContentModerator/Microsoft.CognitiveServices.ContentModerator-Windows/)
3. Email-Checker : WinForm-App with Content-Moderation features
4. PictureUpload - Gallery : ASP.NET Webapp with Content-Moderation features

### Run the Sample 1
After the build of the Project "VisionAPI-WPF-Samples" from "AI_Article_2"-Solution, press F5 to run the sample.

First, you must obtain a Vision API subscription key by [following the instructions on this website](<https://www.microsoft.com/cognitive-services/en-us/sign-up>).

Locate the text edit box saying "Paste your subscription key here to start" on
the top right corner. Paste your subscription key. You can choose to persist
your subscription key in your machine by clicking "Save Key" button. When you
want to delete the subscription key from the machine, click "Delete Key" to
remove it from your machine.

Microsoft will receive the images you upload and may use them to improve the Computer Vision
API and related services. By submitting an image, you confirm you have consent
from everyone in it.

## The Sample 2 - Content Moderator Client Library
The client library is a thin C\# client wrapper for the Content Moderator API.

## The Sample 3 - Email-Checker
This is the Winform Desktop-App that demonstrates evaluation of the Emails-Content of an Outlook-Account
using Outlook COM-Intreface and the Content Moderator API.

## The Sample 2 - Content Moderator Client Library
This is the Winform Desktop-App that demonstrates automatic checking of an uploaded file for the sensible content using the Content Moderator API.


### Build and Run the Samples N°N° 2 - 4 Library
 1. Starting in the folder where you clone the repository
 
 2. Start Microsoft Visual Studio 2015 and select `File > Open > Project/Solution`.
 
 3. Double-click the Visual Studio 2015 Solution (.sln) file.

 4. Press Ctrl+Shift+B, or select `Build > Build Solution`.
 
 5. If needed use NuGet Packet-Manager to solve projects dependecies (see more at https://www.nuget.org/)

## License
All demo and sample projects are licensed with the MIT License. For more details, see
[LICENSE](<https://github.com/mdobro1/AI_Article_2/blob/master/LICENSE>).

Sample images are licensed separately, please refer to [LICENSE-IMAGE](<https://github.com/Microsoft/Cognitive-Vision-Windows/blob/master/LICENSE-IMAGE.md>).

## Developer Code of Conduct
This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/).

Developers using Cognitive Services, including this client library & sample, are expected to follow the “Developer Code of Conduct for Microsoft Cognitive Services”, found at [http://go.microsoft.com/fwlink/?LinkId=698895](http://go.microsoft.com/fwlink/?LinkId=698895).
