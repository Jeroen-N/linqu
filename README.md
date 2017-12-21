##Handleiding Magisco Back-end
In dit document wordt beschreven waar de back-end van Magisco te vinden is en hoe deze uit te voeren is. 
De back-end is geschreven in C# met behulp van .NET Core 2.0 en Entity Framework core 2.0. Verder maakt deze gebruik van een MSSQL database en Swagger. In de toekomst komt hier Azure AD B2C bij.
 
##Tools
Voor versiebeheer (optioneel) en het downloaden van de code is het mogelijk een tool te gebruiken, hiervoor adviseren wij SourceTree. 
Om de code te bekijken kan je gebruik maken van een tekst editor of IDE naar keuze. Hiervoor adviseren wij Visual Studio Community voor de Windows gebruikers en Visual Studio Code voor gebruikers van exotische Linux en Unix varianten. 
Om de back-end uit te voeren is enkel Docker (CE) nodig. Docker is hier te downloaden voor zowel Windows als Linux. Voor het runnen van de back-end draaien normaliter 2 containers, dit zullen er in de toekomst meer worden. Op dit moment zijn er de volgende containers:
-	Container 1 bevat de profileservice, answerservice en questionservice.
-	Container 2 bevat een MSSQL Database voor development.
Om deze twee containers goed uit te voeren is het belangrijk dat Docker beschikking heeft over ten minste 4 GB ram geheugen.

##Downloaden
De back-end is op te halen van GitHub, op het moment van schrijven is de url hiervan: https://github.com/Jeroen-N/linqu
Voordat je hierbij kan moet je worden toegevoegd door Jeroen.
Als branching model wordt gebruik gemaakt van Git flow.
-	Features zijn te vinden in de feature branches en worden vervolgens gemerged naar de develop branch.
-	In de develop branch staat de laatste versie van de back-end die nog niet in productie is genomen.
-	In de master branch staat de code die op dit moment in productie is.

 
##Het uitvoeren van de back-end
Na het installeren van Docker en het ophalen van de code ben je klaar om het project uit te gaan voeren. (de api in de lucht te brengen op je computer). In Windows kan dit door de Solution te openen in Visual Studio en op “run” te drukken. 
Op alle andere besturingssystemen (en ook in windows) is dit mogelijk door in powershell/terminal of je favoriete commandline tool de volgende stappen te doorlopen.
1.	Ga naar de map waarin je de back-end hebt opgeslagen. Bijvoorbeeld: C:\workspace\magisco\back-end. Controleer of deze de file: docker-compose.yml bevat. 
2.	Voer vervolgens het commando “docker-compose build” uit. Dit zal de back-end builden in een docker-container. Dit kan wat tijd in beslag nemen maar dit hoef je in het principe maar eenmalig te doen tot er wijzigingen in de code zijn.
3.	Voer vervolgens het commando “docker-compose up” uit. (Om dit op de achtergrond te doen zodat je nog commando’s uit kan voeren terwijl de back-end actief is kan je ook 
“docker-compose up -d” uitvoeren.
Als het goed is is de back-end nu actief. Met het commando “docker ps” kun je dit verifiëren. Als het goed is zijn de 2 containers te zien in het overzicht. Hier staan ook de poorten waarop de containers draaien. 
 
Vervolgens is de api via de poort in het overzicht aan te spreken. Via de browser kun je ook de documentatie in de vorm van een Swagger UI opvragen. Gebruik hiervoor de volgende url: http://localhost:<poort>/swagger hierbij dient de poort vervangen te worden door de poort uit het overzicht, bijvoorbeeld 32768.
