KRYPTERINGSTJÄNST

Krypteringstjänsten är publicerad på AWS - Elastic Beanstalk. 

Länk till projektet på AWS Elastic Beanstalk (root-url utan endpoints):
http://encryptapi-env.eba-z3uguycu.eu-north-1.elasticbeanstalk.com/

Länkar till projektets endpoints: 
*Encrypt
/encrypt?myName=Name&shift=3

* Decrypt
/decrypt?myName=Dlqd&shift=3 

KRYPTERING:
För att kryptera skriver du in '/encrypt?myName=Name&shift=3' efter root-url, som ger resultatet: Qdph
'Name' ändras till valfritt namn som ska krypteras. 
Om du vill ändra hur mycket du vill att programmet ska förflytta bokstäverna i alfabetet (åäö fungerar inte) från 1-25, så kan du skriva in ny siffra/siffror efter '&shift='
I exemplet förflyttas bokstäverna tre steg. 

AVKRYPTERING: 
För att avkryptera skriver du in /decrypt?myName=Qdph&shift=3 efter root-url, som ger resultatet: Name
eller så kan detta ändras till valfri krypterad text. 
Om du vill ändra hur mycket du vill att programmet ska förflytta bokstäverna i alfabetet (åäö fungerar inte) från 1-25, så kan du skriva in ny siffra/siffror efter '&shift='