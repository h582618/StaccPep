# Stacc code challenge 2021

## Oppgavebeskrivelse
Har valgt å lage både et API og en web APP, samt autentisering for denne.
Web app skrevet i blazor for å utføre KYC sjekk av både personer og bedrifter.
Kunne også autentisert API mot web app med client credentials flow, men droppet dette i denne omgang.
Har ikke fokusert mye på frontend, så er ikke så vakkert som det kunne blitt.

## Hvordan kjøre prosjektet
dotnet watch run på både API og web app.

URL 
https://staccpep.azurewebsites.net

## Kommentarer
Valgte å ha en egen side for person sjekk og org sjekk. Dette er for odrens skyld og fordi det er uavhengige API kall for disse.
En utfordring jeg kom over var at pep.csv ikke var tilgjenglig når api var deployet til azure.
Dette kunne løses med å publisere web app som --nozip, ha csv file som ren streng eller lagre fil i eks azure blob storage.
Da jeg ikke har god tid denne uken siden jeg har 2 eksamener om et par dager, så har jeg utelat dette. 
Web app bruker altså deres API deployet. 



