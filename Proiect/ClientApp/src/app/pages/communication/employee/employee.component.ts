import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from '../../../../environments/environment.prod';
import { Employee } from '../../../data/interfaces/employee';

@Component({
  selector: 'app-comp2',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss']
})
export class EmployeeComponent implements OnInit {

  public title: string = 'Employee request';
  public employeeApi1: Employee = { id: 0, firstName: '', lastName: '' };
  public employeeApi2: Employee = { id: 0, firstName: '', lastName: '' };
  public employeeApi3: Employee = { id: 0, firstName: '', lastName: '' };
  public employeeApi4: Employee = { id: 0, firstName: '', lastName: '' };
  public employeeApi5: Employee = { id: 0, firstName: '', lastName: '' };

  private readonly apiUrl = environment.apiUrl;
  constructor(private readonly httpClient: HttpClient) { }

  ngOnInit(): void {
    let Id = 1;

    this.httpClient.get<Employee>(`${this.apiUrl}_employeeService/byid/${Id}`).subscribe((data) => {
      console.log('get succesful', data);
      this.employeeApi1 = data;
    })
  }

}
