/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab.pkg9.y.pkg10;
import java.util.*;

/**
 *
 * @author Duvan
 */
public class Lab9Y10 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        String text = "";
        String res = "";
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();

        for (int i = 0; i < n; i++) 
        {
            text = input.next();
            int cont = 0;

            if (!text.contains("~")) 
            {
                res += "YES\n";
                continue;
            }
            
            String[] separar = text.split("\\|");

            int probablePos = 0;

            for (int k = 0; k < separar.length; k++) 
            {
                //boolean parentesis=true;
                String text1 = separar[k]; // Text1 contiene a cada paréntesis.
                for (int j = 1; j < text1.length() - 1; j++) 
                {
                    if (probablePos == 0) 
                    { // ciclo for de cada paréntesis.

                        char getChar = text1.charAt(j);

                        if (getChar == '&' || getChar == '~') 
                        {

                            continue;
                        }

                        if ((text1.contains("&" + getChar + "&") && text1.contains("~" + getChar)) || (text1.contains("(" + getChar)
                                && text1.contains("~" + getChar)) || (text1.contains("&" + getChar) && text1.contains("~" + getChar))) 
                        {
                            cont++;
                            break;
                        } 
                        else 
                        {
                            cont = 0;
                            continue;
                        }
                    }
                }
                if (cont == 0) 
                {
                    probablePos = 1;
                    res += "YES\n";
                    break;
                }
            }
            if (cont != 0) 
            {
                res += "NO\n";
            }
        }
        System.out.println(res);
    }
}
