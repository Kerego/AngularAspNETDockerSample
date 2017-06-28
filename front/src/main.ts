import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';


if(module['hot'])
{
  module['hot'].accept();
  module['hot'].dispose(() => {
    // Before restarting the app, we create a new root element and dispose the old one
    const oldRootElem = document.querySelector('app-root');
    const newRootElem = document.createElement('app-root');
    oldRootElem.parentNode.insertBefore(newRootElem, oldRootElem);
    
    modulePromise.then(appModule => appModule.destroy());
  });
}
else if (environment.production) {
  enableProdMode();
}

const modulePromise = platformBrowserDynamic().bootstrapModule(AppModule);
