import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Question } from '../model/question';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  constructor(private http : HttpClient) { }

  getQuestion(idQuestion: number): Observable<Question[]> {
    return this.http.get<Question[]>("https://localhost:44340/api/questions/"+idQuestion);
  }
}
