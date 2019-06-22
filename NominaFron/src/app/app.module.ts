import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { EmpleoyeeService } from './empleoyee.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  
import { HttpClientModule, HttpClient } from '@angular/common/http';  
import {  
  MatButtonModule, MatMenuModule, MatDatepickerModule,MatNativeDateModule , MatIconModule, MatCardModule, MatSidenavModule,MatFormFieldModule,  
  MatInputModule, MatTooltipModule, MatToolbarModule, MatSelectModule, MatPaginatorModule, MatTableModule,
  MatSortModule, MatPaginatorIntl
} from '@angular/material';  

import { MatRadioModule } from '@angular/material/radio';  
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmpleoyeeComponent } from './empleoyee/empleoyee.component';
import { EmployeeDetailComponent } from './employee-detail/employee-detail.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { EmployeeEditComponent } from './employee-edit/employee-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    EmpleoyeeComponent,
    EmployeeDetailComponent,
    EmployeeAddComponent,
    EmployeeEditComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,  
    ReactiveFormsModule,  
    HttpClientModule,  
    BrowserAnimationsModule,  
    MatButtonModule,  
    MatMenuModule,  
    MatDatepickerModule,  
    MatNativeDateModule,  
    MatIconModule,  
    MatRadioModule,  
    MatCardModule,  
    MatSidenavModule,
    MatSelectModule,  
    MatFormFieldModule,  
    MatInputModule,  
    MatTooltipModule,  
    MatToolbarModule,  
    AppRoutingModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatInputModule
  ],
  providers: [HttpClientModule, EmpleoyeeService, MatDatepickerModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
