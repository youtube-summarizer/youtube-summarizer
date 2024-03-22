import { Component, OnInit } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { ToastrService } from "ngx-toastr";
import { VideoModel } from "src/app/models/dtos/video-model";
import { VideosService } from "src/app/services/videos.service";
import { environment } from "src/environments/environment";

@Component({
  selector: "app-homepage",
  templateUrl: "./homepage.component.html",
  styleUrls: ["./homepage.component.scss"],
})
export class HomepageComponent implements OnInit {
  title: string = "ytb-summarizer";
  videos: VideoModel[] = [];

  constructor(translate: TranslateService, private toastrService: ToastrService, private videosService: VideosService) {
    translate.setDefaultLang(environment.defaultLanguage);
    translate.use(environment.defaultLanguage);
  }

  ngOnInit(): void {
    this.videosService.getAll().subscribe((result: VideoModel[]) => {
      this.videos = result;
      console.log(result);
      if (this.videos) {
        this.toastrService.success("Successuflly got the videos from the server!");
      }
    });
  }
}
