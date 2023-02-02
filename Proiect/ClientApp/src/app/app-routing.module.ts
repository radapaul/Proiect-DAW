import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './pages/communication/employee/employee.component';

const routes: Routes = [{
  path: 'communication',
  loadChildren: () => import('./pages/communication/communication.module').then(m => m.CommunicationModule)
},
  {
    path: 'employee',
    component: EmployeeComponent
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
