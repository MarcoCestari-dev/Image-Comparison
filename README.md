# Image Comparision

Per poter utilizzare questo software è necessario **PRIMA di poterlo compilare correttamente** scaricare PYTHON e installare delle librerie necessarie alla corretta esecuzione degli algoritmi.

- Per il report scaricare il file "Report_GMA.pdf"
- Per la presentazione scaricare il file "Presentazione_GMA.pdf"

# Step By Step
I passi da seguire per far funzionare questo programma sono i seguenti:

1. Prima di tutto, è necessario scaricare e installare la versione di *PYTHON 3.8.7* (https://www.python.org/downloads/release/python-387/ - **64 bit per windows**) e, durante l'installazione, spuntare la checkbox "Add Python 3.8.7 to PATH".
2. **Se** si vuole aprire l'intera soluzione e **modificare/compilare** il codice realizzato in C# e NON solo avviare l'eseguibile è necessario installare *Visual Studio Community*. Questo è indispensabile se si vuole modificare il codice sorgente o l'interfaccia e ricompilarlo.
3. Una volta fatti i passi 1 e 2 è consigliato riavviare il pc.
4. A questo punto aprire un CMD (Prompt Dei Comandi) ed eseguire in questo ordine i seguenti comandi:
- **pip install imutils**
- **pip install numpy**
- **pip install opencv-python**
- **pip install scikit-image**
5. A questo punto dovrebbe essere tutto pronto per avere un programma utilizzabile e funzionante. Per aprire il programma, fare doppio click sul file ImageComparision.exe nella cartella "Image-Comparison-main\ImageComparison\bin\Debug".
- *Qualora si verificassero problemi la prego di contattarmi e cercherò di aiutarla*.

## Visual Studio Community - Setup
- Se si vuole utilizzare Visual Studio Community per la modifica dei file **potrebbe** essere necessario fare lo sblocco dei file resx che automaticamente vengono bloccati quando scaricati da internet.
- Per sbloccarli aprire il zip
1. Portare la cartella nella posizione desiderata
2. premere SHIFT e Click Destro nella folder
3. Aprire una PowerShell
4. Inviare il seguente comando: _"Get-ChildItem %YourFolderPath% -Recurse | Unblock-File"_
