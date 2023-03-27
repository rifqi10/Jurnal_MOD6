using ConsoleApp1;

SayaTubeUser user = new SayaTubeUser("Muhammad Aulia Rifqi Hafid");

SayaTubeVideo video1 = new SayaTubeVideo("Tutorial belajar coding part 1");
SayaTubeVideo video2 = new SayaTubeVideo("Tutorial belajar coding part 2");
SayaTubeVideo video3 = new SayaTubeVideo("Tutorial belajar coding part 3");
SayaTubeVideo video4 = new SayaTubeVideo("Tutorial belajar coding part 4");
SayaTubeVideo video5 = new SayaTubeVideo("Tutorial belajar coding part 5");
SayaTubeVideo video6 = new SayaTubeVideo("Tutorial belajar coding part 6");
SayaTubeVideo video7 = new SayaTubeVideo("Tutorial belajar coding part 7");
SayaTubeVideo video8 = new SayaTubeVideo("Tutorial belajar coding part 8");


user.AddVideo(video1);
user.AddVideo(video2);
user.AddVideo(video3);
user.AddVideo(video4);
user.AddVideo(video5);
user.AddVideo(video6);
user.AddVideo(video7);
user.AddVideo(video8);
user.DetailsVideo();
video1.PrintVideoDetails();
