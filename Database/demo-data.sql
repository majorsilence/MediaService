
-- MediaInfo goes in first 
INSERT INTO `ms_project2`.`MediaInfo` (`IdMediaInfo`, `MediaName`, `Summary`, `Active`, `StoryLine`, `IdMediaType`, `IdLanguage`, `IdMotionPictureRating`, `AverageUserRating`, `MediaYear`, `LastAltered`) 
VALUES (NULL, 'Test Video 1', 'This is a summary for the test video that is number one.', true, 'The discussion of Mr. Collins\'s offer was now nearly at an end, and', 'MOVIE', 1, 5, -1, 2011, '2011/01/13 :19:42:00');
INSERT INTO `ms_project2`.`MediaInfo` (`IdMediaInfo`, `MediaName`, `Summary`, `Active`, `StoryLine`, `IdMediaType`, `IdLanguage`, `IdMotionPictureRating`, `AverageUserRating`, `MediaYear`, `LastAltered`) 
VALUES (NULL, 'A Second Name', 'This is the second summary.', true, 'She retreated from the window, fearful of being seen; and as she walked', 'TV', 1, 6, 4, 1997, '2011/01/13 19:45:00');

-- Next the MediaFiles are inserted and linked to MediaInfo data
INSERT INTO `ms_project2`.`MediaFiles` (`IdMediaFiles`, `IdMediaInfo`, `FileLocation`, `VideoBitrate`, `MediaFileTypeCode`, `MediaLength`) 
VALUES (Null, 1, 'video/big_buck_bunny_480p.webm', 5000, 'VIDEO', 6000);
INSERT INTO `ms_project2`.`MediaFiles` (`IdMediaFiles`, `IdMediaInfo`, `FileLocation`, `VideoBitrate`, `MediaFileTypeCode`, `MediaLength`) 
VALUES (Null, 1, 'coverart/big_buck_bunny.jpg', 0, 'COVERART', 0);



