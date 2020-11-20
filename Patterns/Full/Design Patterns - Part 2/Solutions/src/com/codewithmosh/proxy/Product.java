package com.codewithmosh.proxy;

public class Product {
  private int id;
  private String name;

  public Product(int id) {
    this.id = id;
  }

  public int getId() {
    return id;
  }

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }
}
