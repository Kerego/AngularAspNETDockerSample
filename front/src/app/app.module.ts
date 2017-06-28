import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { MdCardModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { PresentationService } from "app/services/presentation.service";

import { AppComponent } from './app.component';
import { CardComponent } from "app/components/card.component";

import 'hammerjs';

@NgModule({
  declarations: [
    AppComponent,
    CardComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    // BrowserAnimationsModule,
    // MdCardModule
  ],
  providers: [PresentationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
