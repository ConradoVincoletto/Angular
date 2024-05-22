import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {

  public eventos: any =
  [
    {
      Tema: 'Angular',
      Local: 'BH'
    },
    {
      Tema: 'C# DOTNET',
      Local: 'São Paulo'
    },
    {
      Tema: 'Udemy Angular',
      Local: 'Rio de Janeiro'
    }
  ];

}
