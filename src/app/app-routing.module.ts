import { ManageDeliveryComponent } from './homepage/manage-delivery/manage-delivery.component';
import { ViewSuggestionsComponent } from './homepage/manage-delivery/view-suggestions/view-suggestions.component';
import { ViewDeliveryDetailsComponent } from './homepage/manage-delivery/view-delivery-details/view-delivery-details.component';
import { HomecontentComponent } from './homepage/homecontent/homecontent.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ViewHistoryComponent } from './homepage/view-history/view-history.component';
import { ViewDetailsComponent } from './homepage/view-delivery/view-details/view-details.component';
import { ViewDeliveryComponent } from './homepage/view-delivery/view-delivery.component';
import { SignInComponent } from './homepage/sign-in/sign-in.component';
import { ManageCommunityComponent } from './homepage/manage-community/manage-community.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JoinCommunityComponent } from './homepage/join-community/join-community.component';
import { MessagesComponent } from './homepage/manage-delivery/messages/messages.component';

const routes: Routes = [
{path:'', component:HomecontentComponent },
{path:'homecontent',  component: HomecontentComponent},
{path:'joincommunity', component:JoinCommunityComponent},
{path:'managedelivery', component:ManageDeliveryComponent, 
    children:[
      {path:'messages',component:MessagesComponent },
      {path:'deliverydetails',component:ViewDeliveryDetailsComponent },
      {path:'suggestions',component:ViewSuggestionsComponent },
  ]},
{path:'signin', component:SignInComponent},
{path:'viewdeliver', component:ViewDeliveryComponent},
{path:'viewhistory', component:ViewHistoryComponent},
{path:'managecommunity', component:ManageCommunityComponent},

{path:'backtohome', component:HomecontentComponent},

//{path:'**', component:HomecontentComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
