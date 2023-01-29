import { Component, OnInit } from '@angular/core';
import { CommunicationService } from '../../../core/services/communication.service';

@Component({
  selector: 'app-comp1',
  templateUrl: './comp1.component.html',
  styleUrls: ['./comp1.component.scss']
})
export class Comp1Component implements OnInit{


  title = 'title from comp 2';
  constructor(private readonly communicationService: CommunicationService) { }

  ngOnInit(): void {
    this.communicationService.getTitleObservable().subscribe(data => {
      console.log(data);
      if (data)
        this.title = data;
    }
    )
  }
  changeTitle() {
    this.communicationService.titleChanged('new title from comp1');
  }
}
