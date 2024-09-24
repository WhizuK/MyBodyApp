import { UserService } from './../../services/user.service';
import { User } from './../../model/user';
import { Component } from '@angular/core';
import { ProfileFormComponent } from "../../components/profile-form/profile-form.component";
import { Route, Router } from '@angular/router';


@Component({
  selector: 'app-new-profile',
  standalone: true,
  imports: [ProfileFormComponent],
  templateUrl: './new-profile.component.html',
  styleUrl: './new-profile.component.css'
})
export class NewProfileComponent {

  btnAction = "Create"
  btnTitle = "Create new profile"

  constructor(private userService: UserService, private router: Router){


  }

  createProfile(user : User){
     this.userService.CreateUser(user).subscribe((data) =>{

      this.router.navigate([`/`])
     });

  }

}
