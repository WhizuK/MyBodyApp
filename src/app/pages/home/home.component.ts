import { Component, OnInit,  } from '@angular/core';
import { UserService } from '../../services/user.service';
import { User } from '../../model/user';
import { CommonModule } from '@angular/common';
import { BodyComposition } from '../../model/BodyComposition';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, RouterLink, RouterOutlet],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})

export class HomeComponent implements OnInit {
  title = 'my-Body-app';
  user: User[] = [];
  bodyComposition: BodyComposition[] = [];
  userSeach: User[] = [];




  constructor(private userService : UserService){}

  ngOnInit(): void {
     this.userService.GetUser().subscribe(data => {

        data.map((item) => {
          console.log(item);
        })

        this.user = data;
        this.userSeach = data;

     })
  }

seach(event : Event){

   const target = event.target as HTMLInputElement;
   const value = target.value.toLowerCase();

   this.user =this.userSeach.filter(user => {
    return user.name?.toLowerCase().includes(value);
   })
   
}

delete(id:number | undefined){

  this.userService.Delete(id).subscribe(user =>{

    window.location.reload()
  })
}
}
