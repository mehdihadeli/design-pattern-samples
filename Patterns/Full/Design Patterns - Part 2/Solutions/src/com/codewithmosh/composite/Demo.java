package com.codewithmosh.composite;

public class Demo {
  public static void show() {
    var subTeam1 = new Team();
    subTeam1.add(new Truck());
    subTeam1.add(new HumanResource());
    subTeam1.add(new HumanResource());

    var subTeam2 = new Team();
    subTeam2.add(new Truck());
    subTeam2.add(new HumanResource());
    subTeam2.add(new HumanResource());

    var team = new Team();
    team.add(subTeam1);
    team.add(subTeam2);

    team.deploy();
  }
}
