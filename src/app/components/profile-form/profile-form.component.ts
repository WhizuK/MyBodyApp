import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { User } from '../../model/user';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-profile-form',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule, CommonModule,RouterLink, RouterOutlet],
  templateUrl: './profile-form.component.html',
  styleUrls: ['./profile-form.component.css']
})
export class ProfileFormComponent implements OnInit {
  @Output() onSubmite = new EventEmitter<User>();
  @Input()  btnAction!: string;
  @Input()  btnTitle!: string;
  @Input()  userData: User| null=null ;
  profileForm!: FormGroup;

  constructor() {}
  
  ngOnInit(): void {
    console.log(3)
    this.profileForm = new FormGroup({
      name: new FormControl( this.userData ? this.userData.name : '',[Validators.required]),
      bodyComposition: new FormGroup({
        bodyFat: new FormControl(``,[Validators.required]),
        bodyMass: new FormControl('',[Validators.required]),
        bodyWanter: new FormControl('',[Validators.required]),
        weightBone: new FormControl('',[Validators.required])
      }),
      bodyMeasurements: new FormGroup({
        measureChest: new FormControl('',[Validators.required]),
        measureShoulders: new FormControl('',[Validators.required]),
        measureLeftArm: new FormControl('',[Validators.required]),
        measureRightArm: new FormControl('',[Validators.required]),
        measureLeftForeArm: new FormControl('',[Validators.required]),
        measureRightForeArm: new FormControl('',[Validators.required]),
        measureAbs: new FormControl('',[Validators.required]),
        measureLeftThigh: new FormControl('',[Validators.required]),
        measureRightThigh: new FormControl('',[Validators.required]),
        measureLeftCalf: new FormControl('',[Validators.required]),
        measureRightCalf: new FormControl('',[Validators.required])
      })
    });
  }

  OnSubmit(): void {
    console.log(this.profileForm.value);
    this.onSubmite.emit(this.profileForm.value);
  }
}
 