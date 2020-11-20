package com.codewithmosh.proxy;

import java.util.HashMap;
import java.util.Map;

public class DbContext {
  private Map<Integer, Product> updatedObjects = new HashMap<>();

  public Product getProduct(int id) {
    // Automatically generate SQL statements
    // to read the product with the given ID.
    System.out.printf("SELECT * FROM products WHERE product_id = %d \n", id);

    var product = new ProductProxy(id, this);
    product.setName("Product 1");

    return product;
  }

  public void saveChanges() {
    // Automatically generate SQL statements
    // to update the database.
    for (var updatedObject : updatedObjects.values())
      System.out.printf("UPDATE products SET name = '%s' WHERE product_id = %d \n", updatedObject.getName(), updatedObject.getId());

    updatedObjects.clear();
  }

  public void markAsChanged(Product product) {
    updatedObjects.put(product.getId(), product);
  }
}
