import speech_recognition as sr
import sys
import os

r = sr.Recognizer()

json = open('key.json').read()

data = []

fname = sys.argv[1]
wav = fname
txt = fname.replace('.wav', '.txt')

with sr.AudioFile(wav) as source:
    while audio := r.listen(source, phrase_time_limit=30):
    
        try:
            text = r.recognize_google_cloud(audio, language='pl-PL', credentials_json=json)
            if not text:
                continue
            print(text)
            with open(txt, 'a+', encoding='utf-8') as f:
                f.write(text+'\n')
                f.close()
        except:
            pass
