void shortblink() {
  digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(200);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000); 
}

void longblink() {
  digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(2000);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000); 
}

void letter_s() {
  shortblink();
  shortblink();
  shortblink();
}

void letter_o() {
  longblink();
  longblink();
  longblink();
}
  
// the loop function runs over and over again forever
void loop() {
  letter_s();
  letter_o();
  letter_s();
  digitalWrite(LED_BUILTIN, LOW);
  delay(2300); 
}
