import { ApplicationConfig, importProvidersFrom, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideHttpClient } from '@angular/common/http';

import { routes } from './app.routes';
import { SocialAuthServiceConfig, GoogleLoginProvider, SocialLoginModule } from '@abacritt/angularx-social-login';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes),
    provideHttpClient(),
    importProvidersFrom(SocialLoginModule),
    {
      provide: 'SocialAuthServiceConfig',
      useValue: {
        autoLogin: false,
        providers: [
          {
            id: GoogleLoginProvider.PROVIDER_ID,
            provider: new GoogleLoginProvider(
              '894092183213-4rc7qhnstanpbqdbbi18j1516ns8ibf8.apps.googleusercontent.com',
              {
                oneTapEnabled: false,
              }
            )
          }
        ],
        onError: (err) => {
          console.error('שגיאה בהתחברות עם גוגל', err);
        }
      } as SocialAuthServiceConfig
    }
  ]
};
