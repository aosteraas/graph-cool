//
//  NavigationBar.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 24/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI

struct NavigationBar: View {
    private let bagelPink = UIColor(red: 0.95805620825129523, green: 0.28210045499878755, blue: 1, alpha: 1)
    private let bagelFont = UIFont(name: "Chalkboard SE", size: 20)
    init() {
        let navAppearance = UINavigationBar.appearance()
        navAppearance.barTintColor = bagelPink
        navAppearance.titleTextAttributes = [
            .font: bagelFont!,
            .foregroundColor: UIColor.white
        ]
    }
    var body: some View {
        NavigationView {
            Text("SwiftUI")
                .navigationBarTitle("BagelGram", displayMode: .inline)
                .navigationBarItems(trailing:
                    Button("Help") {
                        print("Help tapped!")
                    }
                )
        }
    }
}

struct NavigationBar_Previews: PreviewProvider {
    static var previews: some View {
        NavigationBar()
    }
}
