package com.codewithmosh.flyweight;

import java.util.Objects;

public class CellContext {
  // These are the attributes that can be shared by many cells.
  // That's why I've encapsulated them inside this class.
  // Our CellContextFactory class will ensure that every combination
  // of these attributes will only be stored once.
  private final String fontFamily;
  private final int fontSize;
  private final boolean isBold;

  public CellContext(String fontFamily, int fontSize, boolean isBold) {
    this.fontFamily = fontFamily;
    this.fontSize = fontSize;
    this.isBold = isBold;
  }

  public String getFontFamily() {
    return fontFamily;
  }

  public int getFontSize() {
    return fontSize;
  }

  public boolean isBold() {
    return isBold;
  }

  @Override
  public int hashCode() {
    return Objects.hash(fontFamily, fontSize, isBold);
  }
}
