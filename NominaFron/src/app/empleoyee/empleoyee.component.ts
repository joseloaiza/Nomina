import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { EmpleoyeeService } from '../empleoyee.service';  
import { Empleoyee } from '../empleoyee';  

@Component({
  selector: 'app-empleoyee',
  templateUrl: './empleoyee.component.html',
  styleUrls: ['./empleoyee.component.css']
})
export class EmpleoyeeComponent implements OnInit {

  dataSaved = false;  
  employeeForm: any;   
  allEmpleoyees: Observable<Empleoyee[]>;  
  
  empleoyeeIdUpdate = null;  
  massage = null;  

  constructor(private formbulider: FormBuilder, private empleoyeeService:EmpleoyeeService) { }

  ngOnInit() {
    this.loadAllEmployees();  
  }
  loadAllEmployees() {
  // this.empleoyeeService.getEmployees().subscribe((data: {}) => {
  //  this.empleoyeeForm = data;
  //  })
    
  this.allEmpleoyees = this.empleoyeeService.getEmployees();


  }

  onFormSubmit() {  
    this.dataSaved = false;  
    const employee = this.employeeForm.value;  
   // this.CreateEmployee(employee);  
    this.employeeForm.reset();  
  }  

  loadEmployeeToEdit(employeeId: string) {  
    this.empleoyeeService.getEmployeeById(employeeId).subscribe(employee=> {  
      this.massage = null;  
      this.dataSaved = false;  
      this.empleoyeeIdUpdate = employee.id;  
      this.employeeForm.controls['firstName'].setValue(employee.firstName);  
     this.employeeForm.controls['secondName'].setValue(employee.secondName);  
      this.employeeForm.controls['firstLastName'].setValue(employee.firstLastName);  
      this.employeeForm.controls['secondLastName'].setValue(employee.secondLastName);  
        
    });  
  
  }  

}
