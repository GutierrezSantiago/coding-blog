import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '**', redirectTo: '' } // Redirect unknown routes to home
];
