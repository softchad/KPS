# Komunalinių Paslaugų Sistema

## Aprašymas
Komunalinių paslaugų sistema skirta valdyti gyventojų bendrijų paslaugų kainas. Sistema įgyvendina tris naudotojų lygmenis: **administratorius**, **vadybininkas**, **gyventojas**. 

Projektas kuriamas naudojant objektinio programavimo principus ir „MySQL“ duomenų bazę.

---

## Funkcionalumas
- **Administratorius**:
  - Kuria ir šalina naudotojų paskyras (gyventojus ir vadybininkus).
  - Priskiria naudotojus konkretiems namams ir paslaugoms.
  - Valdo paslaugų sąrašą ir jų kainas.
- **Vadybininkas**:
  - Gali redaguoti priskirto namo paslaugų kainas.
- **Gyventojas**:
  - Gali peržiūrėti jam priskirto namo paslaugų sąrašą ir jų kainas.

---

## Projekto struktūra
- **KomunaliniuPaslauguSistema.sln**: Projektų sprendimas.
- **Database/kps.sql**: SQL failas duomenų bazės struktūros ir pradinės informacijos sukūrimui.
- **Programos failai**:
  - `Program.cs`: Programos įėjimo taškas.
  - `DB.cs`: Duomenų bazės užklausų valdymas.
  - `Login.cs`, `Admin.cs`, `Manager.cs`, `Occupant.cs`: Pagrindinės programos klasės, atsakingos už naudotojų rolėms skirtą logiką.
- **Naudotojo sąsaja**:
  - Kuriama naudojant „Windows Forms“.
  - Kiekvienam naudotojo tipui yra atskiras formos dizainas.

---

## Duomenų bazės struktūra
Duomenų bazėje yra šios lentelės:
- **user**: Naudotojai ir jų rolės.
- **home**: Namai ir jų priskyrimai.
- **service**: Paslaugų sąrašas.
- **price**: Paslaugų kainos konkretiems namams.
- **occupant**: Gyventojų ir namų ryšiai.

SQL failas, reikalingas duomenų bazės inicializavimui, yra `DB/kps.sql`.

---

## Naudojimosi instrukcija
1. **Prijungti prie MySQL**:
   - Importuokite `kps.sql` į savo „MySQL“ duomenų bazę.
   - Redaguokite `App.config`, kad įvestumėte savo MySQL prisijungimo duomenis.
2. **Paleisti projektą**:
   - Atidarykite `KomunaliniuPaslauguSistema.sln` „Visual Studio“ ir paleiskite programą.
3. **Prisijungti**:
   - Administratorius: Peržiūri, kuria, šalina naudotojus, paslaugas ir jų kainas.
   - Vadybininkas: Redaguoja kainas priskirtam namui.
   - Gyventojas: Peržiūri jam priskirtų paslaugų sąrašą ir kainas.

---

## Technologijos
- **Programavimo kalba**: C#
- **IDE**: Visual Studio 2022
- **Duomenų bazė**: MySQL
- **UI**: Windows Forms
- **Versijavimas**: Git

---

## Pasiūlymai tobulinimui
- Pridėti dviejų veiksnių autentifikaciją.
- Integruoti analitikos modulius, leidžiančius stebėti paslaugų naudojimo tendencijas.
- Debesų kompiuterijos integracija.
