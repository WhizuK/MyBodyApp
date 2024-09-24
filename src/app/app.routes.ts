import { Routes } from '@angular/router';
import { NewProfileComponent } from './pages/new-profile/new-profile.component';
import { HomeComponent } from './pages/home/home.component';
import { UpdateComponent } from './pages/update/update.component';

export const routes: Routes = [
    {path:`newProfile`, component:NewProfileComponent},
    {path:``, component:HomeComponent},
    {path:`update/:id`, component:UpdateComponent}
]; 
