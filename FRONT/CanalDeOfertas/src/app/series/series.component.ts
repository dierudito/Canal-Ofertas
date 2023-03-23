import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-series',
  templateUrl: './series.component.html',
  styleUrls: ['./series.component.scss']
})
export class SeriesComponent implements OnInit {
  public series: any = [
    {
      ValorMaximo: 12000,
      ValorMinimo: 3000,
      TaxaMaxima: 12,
      TaxaMinima: 2,
      VariacaoBps: 10
    },
    {
      ValorMaximo: 112000,
      ValorMinimo: 2000,
      TaxaMaxima: 10,
      TaxaMinima: 3,
      VariacaoBps: 5
    }

  ]
  ngOnInit(): void {
  }

}
