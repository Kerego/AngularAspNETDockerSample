import { Component, OnInit, Input } from '@angular/core';
import { Presentation } from "app/models/presentation";

@Component({
  selector: 'card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
	@Input() public presentation: Presentation;
}