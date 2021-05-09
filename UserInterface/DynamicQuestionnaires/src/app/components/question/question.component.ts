import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { QuestionService } from 'src/app/services/question.service';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements OnInit {

  question : any;

  constructor(
    private activatedRoute: ActivatedRoute,
    private questionService: QuestionService
  ) { }

  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(params => {
      let questionId = params['questionId'];
      this.questionService.getQuestion(questionId)
      .subscribe(res=>{
        this.question = res;
      })
  });
  }

  updateAnswer(id:any){
    console.log(id)
    console.log(this.question[id].description)
  }

}
