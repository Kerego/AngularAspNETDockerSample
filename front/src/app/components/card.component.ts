import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
	@Input() public title: string;
	@Input() public subtitle: string;
	@Input() public poster: string;
}