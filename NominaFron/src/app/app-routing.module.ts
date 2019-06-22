import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { EmpleoyeeComponent } from './empleoyee/empleoyee.component';
import { EmployeeDetailComponent } from './employee-detail/employee-detail.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { EmployeeEditComponent } from './employee-edit/employee-edit.component';

const routes: Routes = [
  {
    path: 'empleoyee',
    component: EmpleoyeeComponent,
    data: { title: 'List of employes' }
  },
  {
    path: 'employee-details/:id',
    component: EmployeeDetailComponent,
    data: { title: 'Employee detail' }
  },
  {
    path: 'employee-add',
    component: EmployeeAddComponent,
    data: { title: 'Add Employee' }
  },
  {
    path: 'employee-edit/:id',
    component: EmployeeEditComponent,
    data: { title: 'Edit Employee' }
  },
  { path: '',
    redirectTo: '/empleoyee',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
