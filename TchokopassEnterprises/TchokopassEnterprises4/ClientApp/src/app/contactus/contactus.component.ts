import { Component, Inject, OnInit } from "@angular/core";

// Import the ContactUsMailForm interface
import { ContactUsMailForm } from './contactus.form.interface';

import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from "@angular/router";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { RequestOptions, Request, RequestMethod } from '@angular/http';


@Component({
  selector: 'app-contactus',
  templateUrl: './contactus.component.html',
  styleUrls: ['./contactus.component.css']
})
export class ContactusComponent implements OnInit  {

  ngOnInit() {
  }
  
  contactusmail: ContactUsMailForm[];
  public submitted: boolean;
  public form: FormGroup;

  /*
  form = new FormGroup({
                name: new FormControl(),
                phonenumber: new FormControl(),
                email: new FormControl(),
                subject: new FormControl(),
                message: new FormControl()
  });
  */

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private http: HttpClient,
    private fb: FormBuilder,
    @Inject('BASE_URL') private baseUrl: string) {

    // create an empty object from the contausform interface
    this.contactusmail = <ContactUsMailForm[]>{};

    // initialize the form
    this.createForm();

  }

  
  createForm() {
    this.form = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      phonenumber: ['', Validators.pattern(/^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$/)],
      email: ['', Validators.pattern(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/)],
      subject: ['', Validators.required],
      message: ['', Validators.required]
    });
  }


  onSubmit({ value, valid }: { value: ContactUsMailForm, valid: boolean }) {
    this.submitted = true;
      
    let body = JSON.stringify(value);
    console.log(body);
       
    let headers = new HttpHeaders();

    headers = headers.set('Accept', 'application/json');

    if (body) {
      headers = headers.set('Content-Type', 'application/json');
      console.log(body);
    }
    
    return this.http.post('/api/ContactUsMail', body, { headers }).subscribe(result => {
      alert("Your Email has been sent. Thank you!");
      this.form.reset();
    });

   
  }


  // retrieve a FormControl
  getFormControl(name: string) {
    return this.form.get(name);
  }

  // returns TRUE if the FormControl is valid
  isValid(name: string) {
    var e = this.getFormControl(name);
    return e && e.valid;
  }

  // returns TRUE if the FormControl has been changed
  isChanged(name: string) {
    var e = this.getFormControl(name);
    return e && (e.dirty || e.touched);
  }

  // returns TRUE if the FormControl is invalid after user changes
  hasError(name: string) {
    var e = this.getFormControl(name);
    return e && (e.dirty || e.touched) && !e.valid;
  }

}
