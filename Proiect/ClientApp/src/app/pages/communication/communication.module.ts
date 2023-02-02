import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CommunicationComponent } from './communication.component';

import { ParentComponent } from './parent/parent.component';
import { ChildComponent } from './child/child.component';
import { Comp1Component } from './comp1/comp1.component';
import { EmployeeComponent } from './employee/employee.component';
import { CommunicationRoutingModule } from './communication-routing.module';

import { MatCardModule } from '@angular/material/card';
import { MatDividerModule } from '@angular/material/divider';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CommunicationComponent,
    ParentComponent,
    ChildComponent,
    Comp1Component,
    EmployeeComponent
  ],
  imports: [
    CommonModule,
    CommunicationRoutingModule,
    MatCardModule,
    MatDividerModule,
    MatButtonModule,
    MatListModule,
    MatInputModule,
    FormsModule
  ]
})
export class CommunicationModule { }
