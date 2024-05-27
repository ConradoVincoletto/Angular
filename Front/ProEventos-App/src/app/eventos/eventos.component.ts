import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { subscribe } from 'diagnostics_channel';
import { response } from 'express';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {

  public eventos: any;

  constructor(private http: HttpClient){}

  ngOnInit(): void
  {
      this.GetEventos();
  }

  public GetEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error));

    this.eventos =
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
    ]}

}
