import { ActivatedRoute, Route, Router } from '@angular/router';
import { User } from './../../model/user';
import { Component, OnInit } from '@angular/core';
import { ProfileFormComponent } from "../../components/profile-form/profile-form.component";
import { UserService } from '../../services/user.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-update',
  standalone: true,
  imports: [ProfileFormComponent, CommonModule],
  templateUrl: './update.component.html',
  styleUrl: './update.component.css'
})
export class UpdateComponent implements OnInit {


  btnAction: string = "Update";
  btnTitle: string = "Update Profile";
  user!: User;

  constructor(private userService : UserService, private route : ActivatedRoute,private Router:Router){

  }

 ngOnInit(): void {

    const id = Number(this.route.snapshot.paramMap.get('id'));
    console.log('ID from route:', id); // Verifique o ID
    this.userService.GetUserId(id).subscribe((data)=> {
      console.log('ID from route2:', id); // Verifique o ID
      this.user = data

      
 
    })
 }

}
 