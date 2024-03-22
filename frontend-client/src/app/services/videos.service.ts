import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { VideoModel } from "../models/dtos/video-model";
import { HttpService } from "./base/http.service";

@Injectable({
  providedIn: "root",
})
export class VideosService {
  constructor(private httpService: HttpService) {}

  getAll(): Observable<VideoModel[]> {
    return this.httpService.get<VideoModel[]>("videos/all");
  }
}
