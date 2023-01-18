import { Injectable } from '@angular/core';
import { AsyncSubject, BehaviorSubject, ReplaySubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CommunicationService {

  private titleBehaviourSubject = new BehaviorSubject<string>('');
  private titleSubject = new Subject<string>();
  private titleAsyncSubject = new AsyncSubject<string>();
  private titleReplaySubject = new ReplaySubject<string>();
  constructor() { }

  titleChanged(value: string) {
    this.titleBehaviourSubject.next(value);
  }

  getTitleObservable() {
    return this.titleBehaviourSubject.asObservable();
  }
}
