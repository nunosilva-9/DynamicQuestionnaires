import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { QuestionnairesService } from 'src/app/services/questionnaires.service';

@Component({
  selector: 'app-new-questionnaire',
  templateUrl: './new-questionnaire.component.html',
  styleUrls: ['./new-questionnaire.component.scss']
})
export class NewQuestionnaireComponent implements OnInit {

  form: FormGroup = new FormGroup({});
  answers : string[] = new Array()
  
  constructor(
    private fb: FormBuilder,
    private questionnaireService:QuestionnairesService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      title: this.fb.control('', Validators.required),
      question: this.fb.control('', Validators.required),
      answer: this.fb.control('', Validators.required),
  });
  }

  submit() {
    this.questionnaireService.createQuestionnaire({
      "title":this.form.value.title,
      "question":{
          "description":this.form.value.question,
          "answers":this.answers
      }
    })
    .toPromise()
    .then(res=>{
      this.router.navigateByUrl('/questionnaires')
    })
  }

  addAnswer(){

    if(!this.form.value.answer){
      return;
    }

    this.answers.push(this.form.value.answer)
  }

}
