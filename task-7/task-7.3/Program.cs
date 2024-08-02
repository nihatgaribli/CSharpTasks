// See https://aka.ms/new-console-template for more information
/*
 
 Bir ArrayList yaradın və onu fərqli tipli 5 element ilə doldurun. Bu ArrayList-in elementlərini konsola çap edin.
 
 */

using System.Collections;

ArrayList Elements = new ArrayList();

Elements.Add(2);
Elements.Add("Messi");
Elements.Add(true);
Elements.Add(7.43);
Elements.Add('a');

foreach (var element in Elements)
{
    Console.WriteLine(element + " - " + element.GetType().Name);
}