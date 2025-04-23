import { Routes } from '@angular/router';
import { HowToPlayComponent } from './how-to-play/how-to-play.component';
import { OwnedCardsComponent } from './owned-cards/owned-cards.component';
import { StarterPackComponent } from './starter-pack/starter-pack.component';

export const routes: Routes = [
    {path:'how-to-play', component:HowToPlayComponent},
    {path:'owned-cards', component:OwnedCardsComponent},
    {path:'starter-pack', component:StarterPackComponent},
    {path:'', redirectTo:'how-to-play', pathMatch:'full'}
];
