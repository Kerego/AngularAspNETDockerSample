import { Component, OnInit } from '@angular/core';
import { Presentation } from "app/models/presentation";
import { PresentationService } from "app/services/presentation.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    title = 'Test';
    presentations: Presentation[];

    constructor(private presentationService: PresentationService) {
        
    }

    async ngOnInit(): Promise<void> {
        this.presentations = await this.presentationService.getPresentations();
    }
}
