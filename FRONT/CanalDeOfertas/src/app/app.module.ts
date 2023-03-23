import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OfertasComponent } from './ofertas/ofertas.component';
import { SeriesComponent } from './series/series.component';
import { OrdensComponent } from './ordens/ordens.component';

@NgModule({
  declarations: [
    AppComponent,
    OfertasComponent,
    SeriesComponent,
    OrdensComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
