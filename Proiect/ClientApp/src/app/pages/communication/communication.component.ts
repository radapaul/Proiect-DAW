import { Component, OnChanges, OnDestroy, OnInit, SimpleChange, SimpleChanges } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
@Component({
  selector: 'app-communication',
  templateUrl: './communication.component.html',
  styleUrls: ['./communication.component.scss']
})
export class CommunicationComponent implements OnInit, OnDestroy, OnChanges, MatCardModule {
  public title: string = " Main component";

  constructor() {
    let div = document.getElementById("firstDiv");
    console.log("Constructor div: ",div)
  }

  ngOnChanges(changes: SimpleChanges): void {
    throw new Error('Method not implemented.');
  }
  ngOnDestroy(): void {
    throw new Error('Method not implemented.');
  }
  ngOnInit(): void {
    let div = document.getElementById("firstDiv");
    console.log("ngOnInit div: ", div)
  }
}
