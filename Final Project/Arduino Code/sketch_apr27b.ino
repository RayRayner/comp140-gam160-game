int Switch1 = 2;
int Switch2 = 3;
int Switch3 = 4;
int Switch4 = 5;
int Switch5 = 6;
int Switch6 = 7;
int Switch7 = 8;
int Switch8 = 9;

bool Switch1Bool = false;
bool Switch2Bool = false;
bool Switch3Bool = false;
bool Switch4Bool = false;
bool Switch5Bool = false;
bool Switch6Bool = false;
bool Switch7Bool = false;
bool Switch8Bool = false;

boolean running = false;

void setup() {

  Serial.begin(9600);
  
  pinMode(Switch1, INPUT);
  pinMode(Switch2, INPUT);
  pinMode(Switch3, INPUT);
  pinMode(Switch4, INPUT);
  pinMode(Switch5, INPUT);
  pinMode(Switch6, INPUT);
  pinMode(Switch7, INPUT);
  pinMode(Switch8, INPUT);   

  digitalWrite(Switch1, LOW);
  digitalWrite(Switch2, LOW);
  digitalWrite(Switch3, LOW);
  digitalWrite(Switch4, LOW);
  digitalWrite(Switch5, LOW);
  digitalWrite(Switch6, LOW);
  digitalWrite(Switch7, LOW);
  digitalWrite(Switch8, LOW);

}

void loop() {
  // put your main code here, to run repeatedly:

  

if (digitalRead(Switch1) == HIGH) {
  Switch1Bool = true;
} else {
  Switch1Bool = false;
}
if (digitalRead(Switch2) == HIGH) {
   Switch2Bool = true;
} else {
  Switch2Bool = false;
}
if (digitalRead(Switch3) == HIGH) {
   Switch3Bool = true;
} else {
  Switch3Bool = false;
}
if (digitalRead(Switch4) == HIGH) {
   Switch4Bool = true;
} else {
  Switch4Bool = false;
}
if (digitalRead(Switch5) == HIGH) {
   Switch5Bool = true;
} else {
  Switch5Bool = false;
}
if (digitalRead(Switch6) == HIGH) {
   Switch6Bool = true;
} else {
  Switch6Bool = false;
}
if (digitalRead(Switch7) == HIGH) {
   Switch7Bool = true;
} else {
  Switch7Bool = false;
}
if (digitalRead(Switch8) == HIGH) {
   Switch8Bool = true;
} else {
  Switch8Bool = false;
}

String CompleteInputs = String(Switch1Bool) + "," + String(Switch2Bool) + "," + String(Switch3Bool) + "," + String(Switch4Bool) + "," + String(Switch5Bool) + "," + String(Switch6Bool) + "," + String(Switch7Bool) + "," + String(Switch8Bool);
delay (1000);
Serial.println(CompleteInputs);
}
