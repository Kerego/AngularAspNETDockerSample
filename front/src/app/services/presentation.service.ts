import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';
import { Presentation } from "../models/presentation";

@Injectable()
export class PresentationService {
	constructor(private http: Http) {

	}

	getPresentations(): Promise<Presentation[]>{
		return this.http.get("/api/presentations")
			.map(x => x.json() as Presentation[])
			.toPromise();
	}
}