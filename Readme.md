# Basic info
Will be a webservice kind of like netflix that has a database of videos
and optionally audio files.

This is an exercise in programming.

# Database

The database design is stored in the [Database](Database) folder.  See its readme for more details.

# Admin Tool

The admin tool is in the [Majorsilence.MediaService.AdminTool](Majorsilence.MediaService.AdminTool) folder.  This is a small tool to manage video files (convert to supported formats and load into the database and storage location).

The admin tool is currently a winforms application.

# End user client

The desktop client is currently stored in [Majorsilence.MediaService.Client](Majorsilence.MediaService.Client). 

The client is .net winforms.  This is being switched to a web app hosted in xamarin.forms.

# Web Service

The desktop client is currently stored in [Majorsilence.MediaService.WebService](Majorsilence.MediaService.WebService).  The existing client is php in the "WebService" folder. 

The web service was done with php just because all the cheap host
support php.  This is being switched to .net core asp.

