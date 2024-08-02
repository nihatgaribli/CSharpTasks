// See https://aka.ms/new-console-template for more information
/*
 
Bir ArrayList yaradın və ora bir neçə string əlavə edin.
Foreach döngüsündən istifadə edərək, ArrayList-də olan hər bir stringin uzunluğunu tapın və həmin uzunluğu başqa bir ArrayList-ə əlavə edin.
Hər bir string və onun uzunluğunu ekrana çap edin.

 */

using System.Collections;

ArrayList Text = new ArrayList { "integer", "float", "boolean", "string", "number"};
ArrayList TextLength = new ArrayList();

foreach (string text in Text)
{
    TextLength.Add(text.Length);
}

for(int i = 0; i < Text.Count; i++)
{
    Console.WriteLine(Text[i] + " - " + TextLength[i]);
}